import axios from "axios";
import {idID} from "@mui/material/locale";

export const getProductByCategory = async (categoryId) => {
    try {
        const response = await axios.get(
            `https://localhost:7150/api/product/bycategory/${categoryId}`,
            {
                params: { categoryId },
            }
        );
        return response.data;
    } catch (error) {
        console.error(error);
        return [];
    }
};


export const getProductAll = async () => {
    try {
        const response = await axios.get("https://localhost:7150/api/product");
        return response.data;
    } catch (error) {
        console.error(error);
        return [];
    }
}

//Update product
export const updateProduct = async (product) => {
    try {
        const response = await axios.put(
            `https://localhost:7150/api/product/${product.id}`,
            product
        );
        return response.data;
    } catch (error) {
        console.error(error);
        return null;
    }
};


//Delete product
export const deleteProductById = async (id) => {
    try {
        const response = await axios.delete(`https://localhost:7150/api/product/${id}`);
        return response;
    } catch (error) {
        console.error(error);
        return null;
    }
}

//Create product
export const createProduct = async  (product) => {
    const productApi = {
        name: product.name,
        img: product.img,
        categoryId: product.categoryId,
        description: product.description,
        price: product.price,
    }

    try{
        const response = await axios.post(
            `https://localhost:7150/api/product/create`,
            productApi
        );
        return response;
    } catch (error) {
        console.error(error);
        return null;
    }

}
