import PropTypes from 'prop-types';
import "./card-category.css";

function CardCategory({ category, onClick, isSelected }) {
    const handleClick = () => {
        onClick(category.id);
    };

    return (
        <div
            className={`card-category ${
                isSelected === category.id ? "is-active" : ""
            }`}
            onClick={handleClick}
        >
            <img
                className="card-category-image"
                src={category.img}
                alt="category"
            />
            <span className="card-category-name">{category.name}</span>
        </div>
    );
}

CardCategory.propTypes = {
    category: PropTypes.shape({
        id: PropTypes.number.isRequired,
        img: PropTypes.string.isRequired,
        name: PropTypes.string.isRequired,
    }).isRequired,
    onClick: PropTypes.func.isRequired,
    isSelected: PropTypes.number.isRequired,
};

export default CardCategory;