<script setup>
    import { RouterLink } from 'vue-router'
</script>

<template>
    <div class="drawer">
        <input id="my-drawer" type="checkbox" class="drawer-toggle" />
        <div class="drawer-content">
            <!-- Page content here -->
            <label for="my-drawer" class="btn btn-primary drawer-button">
                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" class="inline-block h-5 w-5 stroke-current"> <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 6h16M4 12h16M4 18h16"></path> </svg>
            </label>
        </div>
        <div class="drawer-side z-10">
            <label for="my-drawer" aria-label="close sidebar" class="drawer-overlay"></label>
            <ul class="menu bg-base-200 text-base-content min-h-full w-80 p-4">
                <!-- Sidebar content here -->
                <li><router-link to="/">Dashboard</router-link></li>
                <li><router-link to="/movies">Movies</router-link></li>
                <li><router-link to="/genres">Genres</router-link></li>
            </ul>
        </div>
    </div>
</template>