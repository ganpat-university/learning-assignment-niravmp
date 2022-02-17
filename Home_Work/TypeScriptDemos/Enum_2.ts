// Demo of enums


enum PrintMedia {
	Newspaper = 1,
	Newsletter = 2,
	Magazine = 3,
	Book = 4
}


let vMedia: PrintMedia = PrintMedia.Magazine;

console.log( vMedia );


// Another example

function getMedia(mediaName: string): PrintMedia {
	if( mediaName === 'Forbes' || mediaName === 'Outlook' )
		return PrintMedia.Magazine;
}

let vMedia2: PrintMedia = getMedia('Outlook');
console.log( 'vMedia2 = ' + vMedia2 );

