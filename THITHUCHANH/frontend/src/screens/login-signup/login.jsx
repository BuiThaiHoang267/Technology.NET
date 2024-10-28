// Login.jsx
// eslint-disable-next-line no-unused-vars
import React, {useState} from "react";
import "./login.css";
import {authenticate} from "../../services/authenticateService.js";

function LoginScreen() {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [error, setError] = useState("");

    const handleSubmit = async (e) => {
        e.preventDefault();
        // Gọi API đăng nhập
        try{
            const response = await authenticate(email, password);
            if(response){
                if(response.role === "admin"){
                    window.location.href = "/admin/product";
                }
                else{
                    window.location.href = "/shoptest/menu";
                }
            } else {
                setError("Tài khoản hoặc mật khẩu không đúng");
            }
        } catch (error) {
            console.error(error);
            setError("Đăng nhập thất bại");
        }


    };

    return (
        <div className={"login"}>
            <div className="login-container">
                <h2>Đăng Nhập</h2>
                <form onSubmit={handleSubmit}>
                    <div className="input-group">
                        <label>Email</label>
                        <input
                            type="username"
                            value={email}
                            onChange={(e) => setEmail(e.target.value)}
                            required
                        />
                    </div>
                    <div className="input-group">
                        <label>Mật khẩu</label>
                        <input
                            type="password"
                            value={password}
                            onChange={(e) => setPassword(e.target.value)}
                            required
                        />
                    </div>
                    <button type="submit" className="button">
                        Đăng Nhập
                    </button>
                    {error && <div className="error-message">{error}</div>}
                </form>
            </div>
        </div>
    );
}

export default LoginScreen;
