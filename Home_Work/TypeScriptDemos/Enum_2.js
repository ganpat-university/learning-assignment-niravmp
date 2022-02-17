// Demo of enums
var PrintMedia;
(function (PrintMedia) {
    PrintMedia[PrintMedia["Newspaper"] = 1] = "Newspaper";
    PrintMedia[PrintMedia["Newsletter"] = 2] = "Newsletter";
    PrintMedia[PrintMedia["Magazine"] = 3] = "Magazine";
    PrintMedia[PrintMedia["Book"] = 4] = "Book";
})(PrintMedia || (PrintMedia = {}));
var vMedia = PrintMedia.Magazine;
console.log(vMedia);
// Another example
function getMedia(mediaName) {
    if (mediaName === 'Forbes' || mediaName === 'Outlook')
        return PrintMedia.Magazine;
}
var vMedia2 = getMedia('Outlook');
console.log('vMedia2 = ' + vMedia2);
