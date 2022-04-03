var gulp = require("gulp");
var concat = require("gulp-concat");
var cssmin = require("gulp-cssmin");
var browserSync = require("browser-sync").create();

gulp.task('browser-sync', function () {
    browserSync.init({
        server: {
            baseDir: "./"
        }
    });
});

gulp.task('watch-css', function () {
    gulp.watch('./styles/**/*.css', ['css']);
})

gulp.task("css", function () {
    return gulp.src([
        './styles/**/*.css',
    ])
        .pipe(concat('site.css'))
        .pipe(cssmin())
        //.pipe(uncss({ html: ['Views/**/*.cshtml'] }))
        .pipe(gulp.dest('wwwroot/css/'));
});

gulp.task("js", function () {
    return gulp.src([
        './js/**/*.js'
    ]).pipe(gulp.dest('wwwroot/js/'));
});


gulp.task('font', function () {
    return gulp.src([

    ]).pipe(gulp.dest('wwwroot/webfonts/'));
});

