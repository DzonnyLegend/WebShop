import agent from "../../App/Api/agent";
import LoadingComponent from "../../App/Layout/LoadingComponent";
import {Product} from "../../App/Models/product";
import ProductList from "./ProductList";
import { useState, useEffect } from "react";

export default function Catalog() {
    const[products, setProducts] = useState<Product[]>([]);
    const[loading, setLoading] = useState(true);

  useEffect(() => {
    agent.Catalog.list()
      .then(products => setProducts(products))
      .catch(error => console.log(error))
      .finally(() => setLoading(false))
  }, [])

  if(loading) return <LoadingComponent message='Loading products...'/>

  
    return(
        <>
            <ProductList products={products} />
           
        </>  
    )
}