import axios from "axios";

const API_URL = "https://localhost:7150/api/category";

export const getCategories = async () => {
    try {
        const response = await axios.get(API_URL);
        return response.data;
    } catch (error) {
        console.error('Error fetching categories:', error);
        throw error;
    }
};