<template>
    <div>
        <h1>Genres</h1>
        <button @click="fetchGenres" :disabled="isLoading">Fetch genres</button>
        <div v-if="isLoading">Loading...</div>
        <div v-if="error">{{ error }}</div>
        <ul v-if="!isLoading && !error">
            <li v-for="genre in genres" :key="genre.id">{{ genre.name }}</li>
        </ul>
    </div>
</template>

<script>
import { genreService } from '@/services/genreService';

export default {
    data() {
        return {
            genres: [],
            isLoading: false,
            error: null,
        };
    },
    methods: {
        async fetchGenres() {
            console.log('Fetching genres...');
            this.isLoading = true;
            this.error = null;
            try {
                this.genres = await genreService.fetchGenres();
            } catch (err) {
                this.error = err.message; // Error message is handled by the interceptor
            } finally {
                this.isLoading = false;
            }
        },
    },
};
</script>