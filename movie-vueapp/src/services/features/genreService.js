import api from '@/services/api'

export const genreService = {
    async fetchGenres() {
        const response = await api.get('/genres');
        return response.data;
    },

    async fetchGenreById(genreId) {
        const response = await api.get(`/genres/${genreId}`);
        return response.data;
    }
}