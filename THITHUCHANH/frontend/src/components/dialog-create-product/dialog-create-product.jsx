
import {Dialog, DialogActions, DialogContent, DialogTitle, TextField, Button} from '@mui/material';
import {useState} from "react";



const ProductCreateDialog = ({open, onClose, onSave}) => {
    // Khởi tạo state cho các trường dữ liệu
    const [name, setName] = useState('');
    const [categoryId, setCategoryId] = useState('')
    const [price, setPrice] = useState('');
    const [img, setImg] = useState('');
    const [description, setDescription] = useState( '');



    // Hàm xử lý khi nhấn nút lưu
    const handleSave = () => {
        const updatedProduct = { name, price, description,categoryId,img};
        onSave(updatedProduct);
        onClose();
    };

    return (

        <Dialog
            open={open}
            onClose={onClose}
            hideBackdrop={true}
        >
            <DialogTitle>Create Product Information</DialogTitle>
            <DialogContent>
                <TextField
                    autoFocus
                    margin="dense"
                    label="Category ID"
                    fullWidth
                    variant="outlined"
                    value={categoryId}
                    onChange={(e) => setCategoryId(e.target.value)}
                />
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
                    autoFocus
                    margin="dense"
                    label="Link Img"
                    fullWidth
                    variant="outlined"
                    value={img}
                    onChange={(e) => setImg(e.target.value)}
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

export default ProductCreateDialog;
