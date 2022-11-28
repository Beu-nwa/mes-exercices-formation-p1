import React from 'react';

class HomeView extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            value: '',
            movies: [],
            reconstructedImg: []
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }
    handleChange(event) {
        this.setState({ value: event.target.value });
    }
    handleSubmit(event) {
        event.preventDefault();
        const url = `https://api.themoviedb.org/3/search/movie?api_key=${this.props.apiKey}&query=${this.state.value}`;
        fetch(url)
            .then(response => response.json())
            .then(data => {
                this.setState({ movies: data.results });
            });
        // console.log(this.data.results)
    }
    render() {
        return (
            <div>
                <form onSubmit={this.handleSubmit}>
                    <label>
                        Movie:
                        <input type="text" value={this.state.value} onChange={this.handleChange} />
                    </label>
                    <input type="submit" value="Submit" />
                </form>
                <ul>
                    {this.state.movies.map(movie => (
                        this.setState({ reconstructedImg: `./${movie.poster_path}`}),
                        <li key={movie.id}>{movie.title} <img src={this.state.reconstructedImg} /> </li>
                    ))}
                </ul>
            </div>
        );
    }
}

export default HomeView;