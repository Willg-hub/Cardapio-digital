import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'

import 'bootstrap/dist/css/bootstrap.min.css';
import { createBrowserRouter, RouterProvider } from "react-router-dom";
import Login from './Pages/Login.jsx';
import Home from './Pages/Home.jsx'



const router = createBrowserRouter([
    {
        path: "/Login",
        element: <Login/>,
    },
    {
        path: "/",
        element: <Home/>
    }
])

createRoot(document.getElementById('root')).render(
    <StrictMode>
        <RouterProvider router={router } />

    </StrictMode>,
);
