import { Navigate, createBrowserRouter } from "react-router-dom";
import App from "../Layout/App";
import HomePage from "../../Features/Home/HomePage";
import Catalog from "../../Features/Catalog/Catalog";
import ProductDetails from "../../Features/Catalog/ProductDetails";
import AboutPage from "../../Features/About/AboutPage";
import ContactPage from "../../Features/Contact/ContactPage";
import ServerError from "../Errors/ServerError";
import NotFound from "../Errors/NotFound";
import BasketPage from "../../Features/Basket/BasketPage";
import CheckoutPage from "../../Features/Checkout/CheckoutPage";
import Login from "../../Features/Account/Login";
import Register from "../../Features/Account/Register";
import RequireAuth from "./RequireAuth";

export const router = createBrowserRouter([
    {
        path: '/',
        element: <App />,
        children: [
            {element: <RequireAuth />, children: [
                {path: 'checkout', element: <CheckoutPage />},
            ]},
            {path: '', element: <HomePage />},
            {path: 'catalog', element: <Catalog />},
            {path: 'catalog/:id', element: <ProductDetails />},
            {path: 'about', element: <AboutPage />},
            {path: 'contact', element: <ContactPage />},
            {path: 'server-error', element: <ServerError />},
            {path: 'not-found', element: <NotFound />},
            {path: 'basket', element: <BasketPage />},
            {path: 'login', element: <Login />},
            {path: 'register', element: <Register />},
            {path: '*', element: <Navigate replace to='/not-found' />}
        ]
    }
])