var gulp = require('gulp');
var sass = require('gulp-sass');

gulp.task('styles', function () {
    gulp.src('./Content/**/*.scss')
        .pipe(sass().on('error', sass.logError))
        .pipe(gulp.dest('./Content/'));
});

gulp.task('default', function () {
    gulp.watch('./Content/**/*.scss', ['styles']);
});