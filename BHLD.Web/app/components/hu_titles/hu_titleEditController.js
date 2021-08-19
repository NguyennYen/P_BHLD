(function (app) {
    app.controller('hu_titleEditController', hu_titleEditController);

    hu_titleEditController.$inject = ['apiService', '$scope', 'notificationService', '$state', 'commonService', '$stateParams'];

    function hu_titleEditController(apiService, $scope, notificationService, $state, commonService, $stateParams) {
        $scope.hu_title = {};
        $scope.ckeditorOptions = {
            languague: 'vi',
            height: '200px'
        }
        $scope.Update_hu_title = Update_hu_title;
        $scope.moreImages = [];
        $scope.GetSeoTitle = GetSeoTitle;

        function GetSeoTitle() {
            $scope.hu_title.Alias = commonService.getSeoTitle($scope.hu_title.Name);
        }

        function load_hu_titleDetail() {
            apiService.get('api/hu_title/getbyid/' + $stateParams.id, null, function (result) {
                console.log(result.data);
                $scope.hu_title = result.data;
                $scope.moreImages = JSON.parse($scope.hu_title.MoreImages);
            }, function (error) {
                notificationService.displayError(error.data);
            });
        }
        function Update_hu_title() {
            $scope.Update_hu_title.MoreImages = JSON.stringify($scope.moreImages)
            apiService.put('api/hu_title/update', $scope.hu_title,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được cập nhật.');
                    $state.go('hu_titles');
                }, function (error) {
                    notificationService.displayError('Cập nhật không thành công.');
                });
        }
        function load_hu_title_Category() {
            apiService.get('api/hu_titlecategory/getallparents', null, function (result) {
                $scope.hu_titleCategories = result.data;
            }, function () {
                console.log('Cannot get list parent');
            });
        }
        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.$apply(function () {
                    $scope.hu_title.Image = fileUrl;
                })
            }
            finder.popup();
        }
        $scope.ChooseMoreImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.$apply(function () {
                    $scope.moreImages.push(fileUrl);
                })

            }
            finder.popup();
        }
        load_hu_titleDetail();
        loadhu_titleDetail();
    }

})(angular.module('bhld.hu_titles'));