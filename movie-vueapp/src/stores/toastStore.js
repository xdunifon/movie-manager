import { ref } from 'vue'
import { defineStore } from 'pinia'

export const useToastStore = defineStore('toast', () => {
    const toasts = ref([])
    const durationDefault = 3000

    function addToast(toast) {
        toasts.value.push(toast);

        // Remove toast after duration
        setTimeout(() => removeToast(toast), toast.duration);
    }

    function removeToast(toast) {
        const index = toasts.value.indexOf(toast);
        toasts.value.splice(index, 1);
    }

    /* Public methods */
    function success(message, duration = durationDefault) {
        addToast({ type: 'success', message, duration })
    }

    function error(message, duration = durationDefault) {
        addToast({ type: 'error', message, duration })
    }

    function info(message, duration = durationDefault) {
        addToast({ type: 'info', message, duration })
    }

    function warning(message, duration = durationDefault) {
        addToast({ type: 'warning', message, duration })
    }

    function clear() {
        toasts.value = []
    }

    return {
        toasts,
        success,
        error,
        info,
        warning,
        clear
    }
})