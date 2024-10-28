import "./header.css";
import {Link} from "react-router-dom";

function Header() {
    return (
        <div className={"header-container"}>
            <img className={"header-logo"} src={"https://jollibee.com.vn/static/version1729782615/frontend/Jollibee/default/vi_VN/images/logo.png"}/>
            <div className={"header-navbar"}>
                <Link to={`/shoptest/home`}>
                    <button className={"header-navbar-item"}>TRANG CHỦ</button>
                </Link>
                <Link to={"/shoptest/menu"}>
                    <button className={"header-navbar-item"}>THỰC ĐƠN</button>
                </Link>
                <Link to={"/shoptest/store"}>
                    <button className={"header-navbar-item"}>CỪA HÀNG</button>
                </Link>
                <Link to={"/shoptest/promotion"}>
                    <button className={"header-navbar-item"}>kHUYẾN MÃI</button>
                </Link>
                <Link to={"/shoptest/service"}>
                    <button className={"header-navbar-item"}>DỊCH VỤ</button>
                </Link>
                <Link to={"/shoptest/contact"}>
                    <button className={"header-navbar-item"}>LIÊN HỆ</button>
                </Link>
                <Link to={"/shoptest/recruitment"}>
                    <button className={"header-navbar-item"}>TUYỂN DỤNG</button>
                </Link>
                <Link to={"/shoptest/news"}>
                    <button className={"header-navbar-item"}>TIN TỨC</button>
                </Link>
            </div>
            <img className={"header-img-hotline"} src={"https://jollibee.com.vn/media/wysiwyg/delivery-lg-rs.png"} />
        </div>
    );
}

export default Header
