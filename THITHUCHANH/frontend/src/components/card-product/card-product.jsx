import PropTypes from 'prop-types';
import "./card-product.css";

function CardProduct({ product }) {
    return (
        <div className={"card-product"}>
            <img
                className={"card-product-image"}
                src={product.img}
                alt={"product"}
            />
            <div className={"card-product-name"}>
                <span>{product.name}</span>
            </div>
            <div className={"card-product-price"}>
                <span>{product.price} VND</span>
            </div>
            <button className={"card-product-button"}>ĐẶT HÀNG</button>
        </div>
    );
}

CardProduct.propTypes = {
    product: PropTypes.shape({
        img: PropTypes.string.isRequired,
        name: PropTypes.string.isRequired,
        price: PropTypes.number.isRequired,
    }).isRequired,
};

export default CardProduct;