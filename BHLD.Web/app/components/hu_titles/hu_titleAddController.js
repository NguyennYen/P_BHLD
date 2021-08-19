(function (app) {
    app.controller('hu_titleAddController', hu_titleAddController);

    hu_titleAddController.$inject = ['apiService', '$scope', 'notificationService', '$state', 'commonService'];

    function hu_titleAddController(apiService, $scope, notificationService, $state, commonService) {
        $scope.hu_title = {
            CreatedDate: new Date(),
            Status: true,
        }
        $scope.ckeditorOptions = {
            languague: 'vi',
            height: '200px'
        }
        $scope.Add_hu_title = Add_hu_title;

        $scope.GetSeoTitle = GetSeoTitle;

        function GetSeoTitle() {
            $scope.hu_title.Alias = commonService.getSeoTitle($scope.hu_title.Name);
        }


        function Addhu_title() {

            $scope.hu_title.MoreImages = JSON.stringify($scope.moreImages)
            apiService.post('api/hu_title/create', $scope.hu_title,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được thêm mới.');
                    $state.go('hu_titles');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }
        function load_hu_title() {
            apiService.get('api/load_hu_title/getallparents', null, function (result) {
                $scope.hu_titles = result.data;
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

        $scope.moreImages = [];

        $scope.ChooseMoreImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.$apply(function () {
                    $scope.moreImages.push(fileUrl);
                })

            }
            finder.popup();
        }
        load_hu_title();
    }

})(angular.module('bhld.hu_titles'));