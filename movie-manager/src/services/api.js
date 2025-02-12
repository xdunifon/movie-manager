import axios from 'axios';

// Create an Axios instance
const apiClient = axios.create({
    baseURL: 'https://localhost:7091/api', // Replace with your .NET API base URL
    timeout: 10000, // Request timeout in milliseconds
    headers: {
        'Content-Type': 'application/json',
    },
});

// Interceptor for request
apiClient.interceptors.request.use(
    (config) => {
        // // Add authorization token or other custom headers if needed
        // const token = localStorage.getItem('movieManagerToken'); // Example: Get token from local storage
        // if (token) {
        //     config.headers.Authorization = `Bearer ${token}`;
        // }
        return config;
    },
    (error) => Promise.reject(error)
);

// Interceptor for response
apiClient.interceptors.response.use(
    (response) => {
        // Handle responses globally (e.g., check for errors)
        return response;
    },
    (error) => {
        // Handle errors globally (e.g., unauthorized, server errors)
        console.error('API error:', error.response || error.message);
        return Promise.reject(error);
    }
);

export default apiClient;
