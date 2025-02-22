<script setup>
import { useToastStore } from '@/stores/toastStore';
const toastStore = useToastStore();
</script>

<template>
    <div v-if="toastStore.toasts.length > 0" class="toast">
        <div v-for="toast in toastStore.toasts" :class="`alert alert-${toast.type}`">
            <span>{{ toast.message }}</span>
        </div>
    </div>
</template>