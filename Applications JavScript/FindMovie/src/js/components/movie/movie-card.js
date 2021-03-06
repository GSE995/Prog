import config from '../../config';

export default class MovieCard {

    constructor(data){
        this.data = data;
    }

    renderTo(fragment){
        let wrapper = this.createCardWrapper(this.data);
        fragment.appendChild(wrapper);
    }

    createCardWrapper(movie){
        let arcticle = document.createElement('div');
        arcticle.classList.add('movie-card');
        arcticle.innerHTML = this.getHTML(movie);
        return arcticle;
    }

    getHTML(data){
        this.data = this.mapData(data);
        const html = `
            <div class="poster" style="background-image: url(${this.data.img})">
                <div class="movie-info">
                    <h4 class="movie-name">
                       <a href="${this.data.id}">${this.data.title} ${this.data.year}</a>
                    </h4>
                    <p class="description">
                        <p>${this.data.popularity}</p>
                        <p>${this.data.overview}</p>
                    </p>
                </div>
            </div>
        `;
        // const html = `
        //     <a href="${this.data.id}" class="movie-link" >
        //         <header class="title-header">
        //             <h3>${this.data.title} ${this.data.year}</h3>
        //         </header>
        //     </a>
        //     <div class="card-block">
        //         <a href="${this.data.id}" class="movie-link" >
        //             <div class="img-card" style="background-image: url(${this.data.img})">
        //             </div>
        //         </a>
        //         <div class="container">
        //             <p>${this.data.popularity}</p>
        //             <p>${this.data.overview}</p>
        //         </div>
        //     </div>
        // `;
        return html;
    }

    mapData(data){
        let validyear = data.first_air_date || data.release_date;
        if(validyear){
            validyear = validyear.split('-')[0];
        }
        return {
            id: data.id,
            title: data.title || data.name || 'Unknown',
            img: this.setPic(data),
            date: data.first_air_date || data.release_date,
            year: validyear,
            popularity: data.popularity,
            overview: this.validOverview(data.overview)     
        }
    }

    setPic(data){
        const src = data.poster_path || data.backdrop_path;
        return (!src) ? config.noImagSrc : `${config.imgUrl}${src}`;
    }

    validOverview(text){
        if(!text) return 'unknown';
        let mas = text.split('');
        let str = mas.slice(0, 120).join('') + '...';
        return str;
    }
}

