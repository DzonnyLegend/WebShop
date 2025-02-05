import { configureStore } from "@reduxjs/toolkit";
import { counterSlice } from "../../Features/Contact/counterSlice";
import { TypedUseSelectorHook, useDispatch, useSelector } from "react-redux";
import { basketSlice } from "../../Features/Basket/basketSlice";
import { catalogSlice } from "../../Features/Catalog/catalogSlice";
import { accountSlice } from "../../Features/Account/accountSlice";

//    export function configureStore() {
//        return createStore(counterReducer);
//    }

export const store = configureStore({
    reducer: {
        counter: counterSlice.reducer,
        basket: basketSlice.reducer,
        catalog: catalogSlice.reducer,
        account: accountSlice.reducer
    }
})

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;

export const useAppDispatch = () => useDispatch<AppDispatch>();
export const useAppSelector: TypedUseSelectorHook<RootState> = useSelector;