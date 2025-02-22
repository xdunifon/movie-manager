<script setup>
import { RouterLink, RouterView } from 'vue-router'
import Header from '@/components/Header.vue'
import Toast from '@/components/common/Toast.vue'
</script>

<template>
  <Header />
  <RouterView />
  <Toast />
</template>

