<script setup>
import { ref, onMounted } from 'vue'
import { genreService } from '@/services/features/genreService'

const genres = ref([])
const isLoading = ref(false)
const error = ref(null)

const fetchGenres = async () => {
    isLoading.value = true
    try {
        const response = await genreService.fetchGenres()
        genres.value = response
    }
    catch (err) {
        error.value = err.message
    }
    finally {
        isLoading.value = false
    }
}

onMounted(() => {
    fetchGenres();
})

</script>

<template>
    <div class="p-3">

        <div class="genres">
            <div class="flex justify-between items-center">
                <div class="font-bold text-(--color-primary) text-2xl">Genres</div>
                <button class="btn btn-primary">Add Movie</button>
            </div>
            <div v-if="isLoading">Loading...</div>
            <div v-if="error">{{ error }}</div>
            <table v-if="!isLoading && !error" class="table">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="movie in genres" :key="movie.id">
                        <td>{{ movie.name }}</td>
                        <td class="text-right"><button class="btn btn-secondary">Edit</button></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</template>
