import api from './api';

export const movieService = {
  async fetchMovies() {
    const response = await api.get('/movies');
    return response.data; // The response is already handled by the interceptor
  },

  async getMovieById(movieId) {
    const response = await api.get(`/movies/${movieId}`);
    return response.data;
  },

  async fetchMoviesTable() {
    const response = await api.get('/movies/table');
    return response.data;
  }

//   async createMovie(movieData) {
//     const response = await api.post('/movies', movieData);
//     return response.data;
//   },

//   async updateMovie(movieId, movieData) {
//     const response = await api.put(`/movies/${movieId}`, movieData);
//     return response.data;
//   },

//   async deleteMovie(movieId) {
//     const response = await api.delete(`/movies/${movieId}`);
//     return response.data;
//   },
};
