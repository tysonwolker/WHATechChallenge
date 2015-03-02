(function () {
    'use strict';
    var app = app || {};
    app.namespace = function (namespaceName) {
        var parts = namespaceName.split('.'),
                parent = app,
                i;
        // strip redundant leading global
        if (parts[0] === "app") {
            parts = parts.slice(1);
        }
        for (i = 0; i < parts.length; i += 1) {
            // create a property if it doesn't exist
            if (typeof parent[parts[i]] === "undefined") {
                parent[parts[i]] = {};
            }
            parent = parent[parts[i]];
        }
        return parent;
    };
    window.app = app;
})();