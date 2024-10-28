// Footer.js
import './footer.css';

const Footer = () => {
    return (
        <footer className="footer">
            <div className="footer-column">
                <div className="footer-company-info">
                    <p>
                        <strong>CÔNG TY TNHH JOLLIBEE VIỆT NAM</strong><br />
                        Tầng 26, Tòa nhà CII Tower, số 152 Điện Biên Phủ, Phường 25,<br />
                        Quận Bình Thạnh, Thành phố Hồ Chí Minh, Việt Nam<br />
                        Điện thoại: (028) 39309168<br />
                        Hotline: 1900-1533<br />
                        Mã số thuế: 0303883266<br />
                        Ngày cấp: 15/07/2008 – Nơi cấp: Cục Thuế Hồ Chí Minh<br />
                        Email góp ý: jbvnhfeedback@jollibee.com.vn
                    </p>
                </div>
            </div>
            <div className="footer-column">
                <div className="footer-quick-links">
                    <p><strong>Liên kết nhanh:</strong></p>
                    <ul>
                        <li>Liên hệ</li>
                        <li>Chính sách và quy định chung</li>
                        <li>Chính sách thanh toán khi đặt hàng</li>
                        <li>Chính sách hoạt động</li>
                        <li>Chính sách bảo mật thông tin</li>
                        <li>Thông tin vận chuyển và giao nhận</li>
                        <li>Thông tin đăng ký giao dịch chung</li>
                        <li>Hướng dẫn đặt phần ăn</li>
                    </ul>
                </div>
            </div>
            <div className="footer-column">
                <div className="footer-social">
                    <p><strong>Kết nối với chúng tôi:</strong></p>
                    <ul>
                        <li>Facebook</li>
                        <li>Email</li>
                    </ul>
                </div>
                <div className="footer-app">
                    <p><strong>Ứng dụng di động:</strong></p>
                    <ul>
                        <li>Google Play</li>
                        <li>App Store</li>
                    </ul>
                </div>
            </div>
            <img src={"https://jollibee.com.vn/media/logo-footer.png"} width={"280px"} height={"280px"}/>

        </footer>
    );
}

export default Footer;
