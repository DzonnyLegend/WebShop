import LoadingComponent from "../../App/Layout/LoadingComponent";
import { useAppDispatch, useAppSelector } from "../../App/Store/configureStore";
import ProductList from "./ProductList";
import { useEffect } from "react";
import { fetchFilters, fetchProductsAsync, productSelectors, setPageNumber, setProductParams } from "./catalogSlice";
import { Grid, Paper } from "@mui/material";
import ProductSearch from "./ProductSearch";
import RadioButtonGroup from "../../App/Components/RadioButtonGroup";
import CheckboxButtons from "../../App/Components/CheckBoxButtons";
import AppPagination from "../../App/Components/AppPagination";

const sortOptions = [
  {value: 'name', label: 'Alphabetical'},
  {value: 'priceDesc', label: 'Price - High to low'},
  {value: 'price', label: 'Price - Low to high'},
]

export default function Catalog() {
    const products = useAppSelector(productSelectors.selectAll);
    const {productsLoaded, status, filtersLoaded, brands, types, productParams, metaData} = useAppSelector(state => state.catalog);
    const dispatch = useAppDispatch();

  useEffect(() => {
    if(!productsLoaded) dispatch(fetchProductsAsync());
  }, [productsLoaded, dispatch])

  useEffect(() => {
    if(!filtersLoaded) dispatch(fetchFilters());
  }, [dispatch, filtersLoaded])

  if(!filtersLoaded) return <LoadingComponent message='Loading products...'/>

  
    return(
        <Grid container columnSpacing={4}>
          <Grid item xs={3}>
            <Paper sx={{mb: 2}}>
                <ProductSearch />
            </Paper>
            <Paper sx={{mb: 2, p: 2}}>
              <RadioButtonGroup
                selectedValue={productParams.orderBy}
                options={sortOptions}
                onChange={(e) => dispatch(setProductParams({orderBy: e.target.value}))}
              />
            </Paper>

            <Paper sx={{mb: 2, p: 2}}>
              <CheckboxButtons
                items={brands}
                checked={productParams.brands}
                onChange={(items: string[]) => dispatch(setProductParams({brands: items}))}
              />
            </Paper>
            <Paper sx={{mb: 2, p: 2}}>
              <CheckboxButtons
                items={types}
                checked={productParams.types}
                onChange={(items: string[]) => dispatch(setProductParams({types: items}))}
              />
            </Paper>
          </Grid>
          <Grid item xs={9}>
            <ProductList products={products} />
          </Grid>
          <Grid item xs={3}/>
          <Grid item xs={9} sx={{mb: 2}}>
            {metaData && 
            <AppPagination 
              metaData={metaData}
              onPageChange={(page: number) => dispatch(setPageNumber({pageNumber: page}))}
            />}
          </Grid>
        </Grid>  
    )
}