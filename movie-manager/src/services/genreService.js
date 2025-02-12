import api from './api';

export const genreService = {
  async fetchGenres() {
    const response = await api.get('/movies/genres');
    return response.data; // The response is already handled by the interceptor
  },

  async getGenreById(genreId) {
    const response = await api.get(`/movies/genres/${genreId}`);
    return response.data;
  },

//   async creategenre(genreData) {
//     const response = await api.post('/Genres', genreData);
//     return response.data;
//   },

//   async updategenre(genreId, genreData) {
//     const response = await api.put(`/Genres/${genreId}`, genreData);
//     return response.data;
//   },

//   async deletegenre(genreId) {
//     const response = await api.delete(`/Genres/${genreId}`);
//     return response.data;
//   },
};
