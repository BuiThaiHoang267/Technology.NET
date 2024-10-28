import './App.css'
import {Route, BrowserRouter as Router, Routes} from 'react-router-dom';
import AdminScreen from "./screens/admin/admin.jsx";
import ShopTestScreen from "./screens/shoptest/shoptest.jsx";

function App() {

    return (
        <Router>
            <Routes>
                <Route path="/shoptest/*" element={<ShopTestScreen/>}/>
                <Route path="/admin/*" element={<AdminScreen/>}/>
            </Routes>
        </Router>
    )
}

export default App
