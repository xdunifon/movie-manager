import axios from 'axios';
import { useToastStore } from '@/stores/toastStore';
const toastStore = useToastStore();

const apiClient = axios.create({
    baseURL: 'https://localhost:44300/api',
    withCredentials: false,
    headers: {
        Accept: 'application/json',
        'Content-Type': 'application/json'
    },
    timeout: 10000
});

// Request Interceptor
apiClient.interceptors.request.use(
    (config) => {
        // Add headers or modify request before sending
        return config;
    },
    (error) => {
        // Handle request errors
        console.error('Request Error:', error);
        toastStore.error('Request Error: Please try again later.');
        return Promise.reject(error);
    }
);

// Response Interceptor
apiClient.interceptors.response.use(
    (response) => {
        // Handle successful response
        return response;
    },
    (error) => {
        // Handle errors globally
        if (error.response) {
            const { status, data } = error.response;

            console.error(`API Error [${status}]:`, data);

            switch (status) {
                case 400:
                    toastStore.error('Bad Request: Please check your input.');
                    break;
                case 401:
                    toastStore.error('Unauthorized: Please log in again.');
                    break;
                case 403:
                    toastStore.error('Forbidden: You do not have permission.');
                    break;
                case 404:
                    toastStore.error('Not Found: The requested resource was not found.');
                    break;
                case 500:
                    toastStore.error('Server Error: Please try again later.');
                    break;
                default:
                    toastStore.error(`Error: ${data?.message || 'An unknown error occurred.'}`);
            }
        } else if (error.request) {
            console.error('No Response Received:', error.request);
            toastStore.error('Error: Please try again later.');
        } else {
            console.error('Error:', error.message);
            toastStore.error('No Response Received: Please try again later.');
        }

        return Promise.reject(error);
    }
);

export default apiClient;
