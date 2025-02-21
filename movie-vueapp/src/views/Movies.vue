<script setup>
import { ref, onMounted } from 'vue'
import { movieService } from '@/services/features/movieService'

const movies = ref([])
const isLoading = ref(false)
const error = ref(null)

const fetchMovies = async () => {
    isLoading.value = true
    try {
        const response = await movieService.fetchMovies()
        movies.value = response
    }
    catch (err) {
        error.value = err.message
    }
    finally {
        isLoading.value = false
    }
}

onMounted(() => {
    fetchMovies();
})

</script>

<template>
    <div class="p-3">

        <div class="flex justify-between items-center">
            <div class="text-(--color-primary) text-3xl font-bold">Movies</div>
            <button class="btn btn-primary">Add Movie</button>
        </div>
        <div v-if="isLoading">Loading...</div>
        <div v-if="error">{{ error }}</div>
        <table v-if="!isLoading && !error" class="table">
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
                    <td class="text-right"><button class="btn btn-secondary">Edit</button></td>
                </tr>
            </tbody>
        </table>
    </div>
</template>
