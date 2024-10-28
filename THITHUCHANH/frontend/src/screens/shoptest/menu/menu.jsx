import "./menu.css";
import CardCategory from "../../../components/card-category/card-category.jsx";
import CardProduct from "../../../components/card-product/card-product.jsx";
import { useEffect, useState } from "react";
import { getCategories } from "../../../services/categoryService.js";
import { getProductByCategory } from "../../../services/productService.js";

function MenuScreen() {
    const [categories, setCategories] = useState([]);
    const [selectedCategory, setSelectedCategory] = useState(1);
    const [products, setProducts] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const data = await getCategories();
                console.log("data:", data);
                setCategories(data);
            } catch (error) {
                console.error("Error fetching categories:", error);
            }
        };

        fetchData();
    }, []);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const data = await getProductByCategory(selectedCategory);
                console.log("data:", data);
                setProducts(data);
            } catch (error) {
                console.error("Error fetching categories:", error);
            }
        };

        fetchData();
    }, [selectedCategory]);

    const handleCategoryClick = (id) => {
        console.log("category:", id);
        setSelectedCategory(id);
    };

    return (
        <div className={"menu-container"}>
            <div className={"menu-category-container"}>
                {categories.map((category) => (
                    <CardCategory
                        key={category.id}
                        category={category}
                        onClick={handleCategoryClick}
                        isSelected={selectedCategory}
                    />
                ))}
            </div>
            <div className={"menu-product-container"}>
                {products.map((product) => (
                    <CardProduct
                        key={product.id}
                        product={product}
                    ></CardProduct>
                ))}
            </div>
        </div>
    );
}

export default MenuScreen;
