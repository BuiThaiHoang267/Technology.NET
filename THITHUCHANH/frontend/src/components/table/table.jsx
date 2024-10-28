// TableComponent.jsx
import React, {useEffect} from 'react';
import './table.css';
import {createProduct, deleteProductById, getProductAll, updateProduct} from "../../services/productService.js";
import ProductDialog from "../dialog-product/dialog-product.jsx";
import ProductCreateDialog from "../dialog-create-product/dialog-create-product.jsx";


function TableComponent() {
    const [product, setProduct] = React.useState([]);
    const [dataTable, setDataTable] = React.useState([]);
    const [pageNumber, setPageNumber] = React.useState(1);
    const [dialogOpen, setDialogOpen] = React.useState(false);
    const [dialogCreateOpen, setDialogCreateOpen] = React.useState(false)
    const [selectedProduct, setSelectedProduct] = React.useState({});

    const itemsPerPage = 8;

    const fetchDate = async () => {
        try {
            const data = await getProductAll();
            console.log("data:", data);
            setProduct(data);
        } catch (error) {
            console.error("Error fetching categories:", error);
        }
    }

    useEffect(() => {
        fetchDate();
    }, []);

    useEffect(() => {
        handlePageChange();
    }, [pageNumber, product]);

    const handlePageChange = () => {
        const startIndex = (pageNumber - 1) * itemsPerPage;
        const endIndex = startIndex + itemsPerPage;
        setDataTable(product.slice(startIndex, endIndex));
    };

    const handleClickButtonNext = () => {
        if (pageNumber * itemsPerPage >= product.length) return;
        setPageNumber((prevPage) => prevPage + 1);
    };

    const handleClickButtonPrevious = () => {
        if (pageNumber === 1) return;
        setPageNumber((prevPage) => prevPage - 1);
    };

    const handleDialogOpen = (product) => {
        setSelectedProduct(product);
        setDialogOpen(true);
    };


    const handleDialogClose = () => setDialogOpen(false);
    const handleDialogCreateOpen = () => setDialogCreateOpen(true);
    const handleDialogCreateClose = () => setDialogCreateOpen(false);

    const handleDelete = async (productId) => {
        try{
            await deleteProductById(productId)
            console.log("Delete Successfully")
            alert("Sản phẩm đã được xóa")
            fetchDate()
        } catch (error) {
            console.error("Error updating product:", error);
        }
    };

    const handleEdit = async (productparams) => {
        const productAPI = {
            id: productparams.id,
            name: productparams.name,
            price: productparams.price,
            description: productparams.description,
        }
        try {
            await updateProduct(productAPI);
            console.log("Product updated successfully!");
            alert("Sản phẩm đã được cập nhật")
            fetchDate(); // Refresh data after update
        } catch (error) {
            console.error("Error updating product:", error);
        }
    };

    const handleCreate = async (product) => {
        try
        {
            await createProduct(product);
            console.log("Create successfully")
            alert("Tạo sản phẩm thành công")
            fetchDate();
        }
        catch (error) {
            console.error("Error updating product:", error);
        }
    }

    return (
        <div className={"table"}>
            <button className={"btn-create-product"} onClick={() => handleDialogCreateOpen()}>Create</button>
            <ProductCreateDialog
                open={dialogCreateOpen}
                onClose={handleDialogCreateClose}
                onSave={handleCreate}
            />
            <table className="table">
                <thead>
                <tr>
                    <th className="table-cell">ID</th>
                    <th className="table-cell">Danh mục</th>
                    <th className="table-cell">Name</th>
                    <th className="table-cell">Price</th>
                    <th className="table-cell"></th>
                    <th className="table-cell"></th>
                </tr>
                </thead>
                <tbody>
                {dataTable.map((item) => (
                    <tr key={item.id} className={"header-row"}>
                        <td className="table-cell">{item.id}</td>
                        <td className="table-cell">{item.categoryName}</td>
                        <td className="table-cell">{item.name}</td>
                        <td className="table-cell">{item.price} đ</td>
                        <td className="table-cell actions-cell">
                            <button onClick={() => handleDialogOpen(item)} className="edit-btn">
                                <img className={"edit-btn-logo"}
                                     src={"https://cdn3.iconfinder.com/data/icons/feather-5/24/edit-64.png"}/>
                            </button>

                        </td>
                        <td className="table-cell actions-cell">
                            <button onClick={() => handleDelete(item.id)} className="delete-btn">
                                <img className={"edit-btn-logo"}
                                     src={"https://cdn3.iconfinder.com/data/icons/feather-5/24/trash-2-64.png"}/>
                            </button>

                        </td>
                    </tr>
                ))}
                </tbody>
            </table>
            <div className={"page-container"}>
                <button className={"page-btn"} onClick={handleClickButtonPrevious}>Previous</button>
                <button className={"page-btn"} onClick={handleClickButtonNext}>Next</button>
            </div>
            {selectedProduct && (
                <ProductDialog
                    open={dialogOpen}
                    onClose={handleDialogClose}
                    onSave={handleEdit}
                    product={selectedProduct}
                />
            )}
        </div>
    );
}

export default TableComponent;
