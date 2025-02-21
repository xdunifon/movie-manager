import api from '@/services/api'

export const movieService = {
    async fetchMovies() {
        const response = await api.get('/movies');
        return response.data;
    },

    async fetchMovieById(movieId) {
        const response = await api.get(`/movies/${movieId}`);
        return response.data;
    }
}