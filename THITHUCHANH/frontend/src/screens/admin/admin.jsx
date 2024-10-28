import './admin.css'
import {Link, Route, Routes} from "react-router-dom";
import DashBoardScreen from "./dashboard/dash-board.jsx";
import ProductScreen from "./product/product.jsx";

function AdminScreen() {
    return (
        <div className={"admin-container"}>
            <div className={"admin-navbar"}>
                <div className={"admin-logo"}>
                    <img className={"admin-logo-img"}
                         src={"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRwhfatLFbKbxYoN5lUKlVhl71_fj3LzjS19w&s"}/>
                    <span className={"admin-logo-text"}>Jollibee</span>
                </div>
                <separator className={"admin-separator"}></separator>
                <Link to={"/admin/dashboard"} className={"admin-navbar-link"}>
                    <button className={"admin-navbar-button"}>Dash board</button>
                </Link>
                <Link to={"/admin/category"} className={"admin-navbar-link"}>
                    <button className={"admin-navbar-button"}>Danh mục sản phẩm</button>
                </Link>
                <Link to={"/admin/product"} className={"admin-navbar-link"}>
                    <button className={"admin-navbar-button"}>Quản lý sản phẩm</button>
                </Link>
                <Link to={"/admin/order"} className={"admin-navbar-link"}>
                    <button className={"admin-navbar-button"}>Quản lý Order</button>
                </Link>
            </div>
            <div className={"admin-content"}>
                <Routes>
                    <Route path={"/dashboard"} element={<ProductScreen/>} />
                    <Route path={"/category"} element={<DashBoardScreen></DashBoardScreen>} />
                    <Route path={"/product"} element={<ProductScreen/>} />
                    <Route path={"/order"} element={<DashBoardScreen/>} />
                </Routes>
            </div>
        </div>
    );
}

export default AdminScreen