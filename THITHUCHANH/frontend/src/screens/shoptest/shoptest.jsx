import Header from "../../components/header/header.jsx";
import Footer from "../../components/footer/footer.jsx";
import './shoptest.css'
import {Route, Routes} from "react-router-dom";
import MenuScreen from "./menu/menu.jsx";

function ShopTestScreen() {
    return (
        <div className={'shop-container'}>
            <Header></Header>
            <div className={"shop-content"}>
                <Routes>
                    <Route path={"/home"} element={<h1>Trang chủ</h1>}/>
                    <Route path={"/menu"} element={<MenuScreen/>}/>
                    <Route path={"/store"} element={<h1>Cửa hàng</h1>}/>
                    <Route path={"/promotion"} element={<h1>Khuyến mãi</h1>}/>
                    <Route path={"/service"} element={<h1>Dịch vụ</h1>}/>
                    <Route path={"/contact"} element={<h1>Liên hệ</h1>}/>
                    <Route path={"/recruitment"} element={<h1>Tuyển dụng</h1>}/>
                    <Route path={"/news"} element={<h1>Tin tức</h1>}/>
                </Routes>
            </div>
            <Footer></Footer>
        </div>
    )
}

export default ShopTestScreen