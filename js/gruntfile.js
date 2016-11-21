module.exports = function (grunt) {

    //configure main project settings
    grunt.initConfig({

        //basic settings and info about our plugings
        pkg: grunt.file.readJSON('package.json'),

        //name of plugin (plugin name without the "grunt-contrib-")
        uglify: {
            dist: {
                files: {
                    'controller.min.js': ['controller.js']
                }

            }
        }

    });

//load the plugin

grunt.loadNpmTasks('grunt-contrib-uglify');
grunt.loadNpmTasks('grunt-contrib-uglify');

grunt.registerTask('default', ['uglify']);
};