
(function () {
    angular.module('bhld.hu_titles', ['bhld.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('hu_title', {
                url: "/hu_titles",
                parent: 'base',
                templateUrl: "/app/components/hu_title/hu_titleListView.html",
                controller: "hu_titleListController"
            }).state('hu_title_add', {
                url: "/hu_title_add",
                parent: 'base',
                templateUrl: "/app/components/hu_title/hu_titleAddView.html",
                controller: "hu_titleAddController"
            })
            .state('hu_title_import', {
                url: "/hu_title_import",
                parent: 'base',
                templateUrl: "/app/components/hu_title/hu_titleImportView.html",
                controller: "hu_titleImportController"
            })
            .state('hu_title_edit', {
                url: "/hu_title_edit/:id",
                parent: 'base',
                templateUrl: "/app/components/hu_title/hu_titleEditView.html",
                controller: "hu_titleEditController"
            });
    }
})();