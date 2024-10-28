// Login.jsx
// eslint-disable-next-line no-unused-vars
import React, { useState } from "react";
import "./login.css";

function LoginScreen() {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [error, setError] = useState("");

    const handleSubmit = (e) => {
        e.preventDefault();

        // Giả lập kiểm tra đăng nhập đơn giản
        if (email === "user@example.com" && password === "password") {
            alert("Đăng nhập thành công!");
            setError("");
        } else {
            setError("Email hoặc mật khẩu không đúng.");
        }
    };

    return (
        <div className="login-container">
            <h2>Đăng Nhập</h2>
            <form onSubmit={handleSubmit}>
                <div className="input-group">
                    <label>Email</label>
                    <input
                        type="email"
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
    );
}

export default LoginScreen;
