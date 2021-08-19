(function (app) {
    app.controller('hu_titleListController', hu_titleListController);

    hu_titleListController.$inject = ['$scope', 'apiService', 'notificationService', '$ngBootbox', '$filter'];

    function hu_titleListController($scope, apiService, notificationService, $ngBootbox, $filter) {
        $scope.hu_titles = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.gethu_titles = gethu_titles;
        $scope.keyword = '';

        $scope.search = search;

        $scope.deletehu_title = deletehu_title;

        $scope.selectAll = selectAll;

        $scope.deleteMultiple = deleteMultiple;
        $scope.exportExcel = exportExcel;
        $scope.exportPdf = exportPdf;
        function exportExcel() {
            var config = {
                params: {
                    filter: $scope.keyword
                }
            }
            apiService.get('/api/hu_title/ExportXls', config, function (response) {
                if (response.status = 200) {
                    window.location.href = response.data.Message;
                }
            }, function (error) {
                notificationService.displayError(error);

            });
        }

        function exportPdf(hu_titleId) {
            var config = {
                params: {
                    id: hu_titleId
                }
            }
            apiService.get('/api/hu_title/ExportPdf', config, function (response) {
                if (response.status = 200) {
                    window.location.href = response.data.Message;
                }
            }, function (error) {
                notificationService.displayError(error);

            });
        }
        function deleteMultiple() {
            var listId = [];
            $.each($scope.selected, function (i, item) {
                listId.push(item.ID);
            });
            var config = {
                params: {
                    checkedhu_titles: JSON.stringify(listId)
                }
            }
            apiService.del('api/hu_title/deletemulti', config, function (result) {
                notificationService.displaySuccess('Xóa thành công ' + result.data + ' bản ghi.');
                search();
            }, function (error) {
                notificationService.displayError('Xóa không thành công');
            });
        }

        $scope.isAll = false;
        function selectAll() {
            if ($scope.isAll === false) {
                angular.forEach($scope.hu_titles, function (item) {
                    item.checked = true;
                });
                $scope.isAll = true;
            } else {
                angular.forEach($scope.hu_titles, function (item) {
                    item.checked = false;
                });
                $scope.isAll = false;
            }
        }

        $scope.$watch("hu_title", function (n, o) {
            var checked = $filter("filter")(n, { checked: true });
            if (checked.length) {
                $scope.selected = checked;
                $('#btnDelete').removeAttr('disabled');
            } else {
                $('#btnDelete').attr('disabled', 'disabled');
            }
        }, true);

        function deletehu_title(id) {
            $ngBootbox.confirm('Bạn có chắc muốn xóa?').then(function () {
                var config = {
                    params: {
                        id: id
                    }
                }
                apiService.del('api/hu_title/delete', config, function () {
                    notificationService.displaySuccess('Xóa thành công');
                    search();
                }, function () {
                    notificationService.displayError('Xóa không thành công');
                })
            });
        }

        function search() {
            gethu_titles();
        }

        function gethu_titles(page) {
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 20
                }
            }
            apiService.get('/api/hu_title/getall', config, function (result) {
                $scope.hu_titles = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pagesCount = result.data.TotalPages;
                $scope.totalCount = result.data.TotalCount;
            }, function () {
                console.log('Load hu_title failed.');
            });
        }

        $scope.gethu_titles();
    }
})(angular.module('bhld.hu_titles'));