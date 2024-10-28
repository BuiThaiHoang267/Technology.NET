import React, {useState} from 'react';
import {Dialog, DialogActions, DialogContent, DialogTitle, TextField, Button} from '@mui/material';
import "./dialog-product.css"


const ProductDialog = ({open, onClose, onSave, product}) => {
    // Khởi tạo state cho các trường dữ liệu
    const [id, setId] = useState(product.name || '');
    const [name, setName] = useState(product.name || '');

    const [price, setPrice] = useState(product?.price || '');
    const [description, setDescription] = useState(product?.description || '');

    React.useEffect(() => {
        if (product) {
            setId(product.id);
            setName(product.name || '');
            setPrice(product.price || '');
            setDescription(product.description || '');
        }
    }, [product]);

    // Hàm xử lý khi nhấn nút lưu
    const handleSave = () => {
        const updatedProduct = {...product,id, name, price, description};
        onSave(updatedProduct);
        onClose();
    };

    return (

        <Dialog
            open={open}
            onClose={onClose}
            hideBackdrop={true}
        >
            <DialogTitle>Update Product Information</DialogTitle>
            <DialogContent>
                <TextField
                    autoFocus
                    margin="dense"
                    label="Name"
                    fullWidth
                    variant="outlined"
                    value={name}
                    onChange={(e) => setName(e.target.value)}
                />
                <TextField
                    margin="dense"
                    label="Price"
                    fullWidth
                    variant="outlined"
                    type="number"
                    value={price}
                    onChange={(e) => setPrice(e.target.value)}
                />
                <TextField
                    margin="dense"
                    label="Description"
                    fullWidth
                    variant="outlined"
                    value={description}
                    onChange={(e) => setDescription(e.target.value)}
                />
            </DialogContent>
            <DialogActions>
                <Button onClick={onClose} color="primary">Cancel</Button>
                <Button onClick={handleSave} color="primary">Save</Button>
            </DialogActions>
        </Dialog>
    );
};

export default ProductDialog;
