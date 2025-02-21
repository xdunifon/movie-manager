import axios from 'axios';

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
        config.headers['Authorization'] = `Bearer ${localStorage.getItem('token')}`;
        config.headers['Content-Type'] = 'application/json';

        return config;
    },
    (error) => {
        // Handle request errors
        console.error('Request Error:', error);
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
                    alert('Bad Request: Please check your input.');
                    break;
                case 401:
                    alert('Unauthorized: Please log in again.');
                    break;
                case 403:
                    alert('Forbidden: You do not have permission.');
                    break;
                case 404:
                    alert('Not Found: The requested resource was not found.');
                    break;
                case 500:
                    alert('Server Error: Please try again later.');
                    break;
                default:
                    alert(`Error: ${data?.message || 'An unknown error occurred.'}`);
            }
        } else if (error.request) {
            console.error('No Response Received:', error.request);
            alert('Network error: Please check your connection.');
        } else {
            console.error('Error:', error.message);
            alert(`Error: ${error.message}`);
        }

        return Promise.reject(error);
    }
);

export default apiClient;
