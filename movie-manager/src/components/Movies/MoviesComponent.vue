<template>
    <div class="movies">
        <div class="movies-header">
            <h1>Movies</h1>
            <button class="btn-add-movie">+</button>
        </div>
        <div v-if="isLoading">Loading...</div>
        <div v-if="error">{{ error }}</div>
        <table v-if="!isLoading && !error" class="movies-table">
            <thead>
                <tr>
                    <th>Released</th>
                    <th>Name</th>
                    <th>Description</th>
                    <th>Duration</th>
                    <th>Genre</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="movie in movies" :key="movie.id">
                    <td>{{ movie.dateReleased }}</td>
                    <td>{{ movie.name }}</td>
                    <td>{{ movie.description }}</td>
                    <td>{{ movie.duration }} min</td>
                    <td>{{ movie.genre }}</td>
                    <td><button class="btn-update-movie">Edit</button></td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
import { movieService } from '@/services/movieService';

export default {
    data() {
        return {
            movies: [],
            isLoading: false,
            error: null,
        };
    },
    methods: {
        async fetchMovies() {
            console.log('Fetching movies...');
            this.isLoading = true;
            this.error = null;
            try {
                this.movies = await movieService.fetchMoviesTable();
            } catch (err) {
                this.error = err.message; // Error message is handled by the interceptor
            } finally {
                this.isLoading = false;
            }
        },
    },
    mounted() {
        this.fetchMovies();
    }
};
</script>

<style lang="scss" scoped>
    .movies {
        padding: 2rem;

        .movies-table {
            background-color: var(--color-background-mute);
            border-radius: 0.5rem;
            padding: 0.5rem;

            th {
                border-bottom: 2px solid var(--color-text);
                text-align: left;
            }

            td {
                padding: 0.5rem;
            }

            .btn-update-movie {
                background-color: var(--color-primary);
                color: white;
                border: none;
                border-radius: 0.5rem;
                padding: 0.5rem;
                cursor: pointer;
                transition: 0.2s ease-out;

                &:hover {
                    background-color: var(--color-primary-dark);
                }
            }
        }

        .movies-header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 1rem;

            h1 {
                margin: 0;
            }

            .btn-add-movie {
                background-color: var(--color-primary);
                color: white;
                border: none;
                border-radius: 50%;
                width: 2rem;
                height: 2rem;
                font-size: 1.5rem;
                cursor: pointer;
                transition: 0.2s ease-out;

                &:hover {
                    background-color: var(--color-primary-dark);
                }
            }
        }
    }
</style>