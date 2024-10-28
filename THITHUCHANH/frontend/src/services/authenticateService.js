import axios from "axios";

export const authenticate = async (username, password) => {
    try {
        const response = await axios.post(
            "https://localhost:7150/api/user/login",
            {
                username: username,
                password: password,
            }
        );
        return response.data;
    } catch (error) {
        console.error(error);
        return null;
    }
}