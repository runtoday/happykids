import React from "react";
import {Link} from 'react-router-dom';

function CardProduct(props) {
    const { product } = props;
    return (
<div class="product-card" >
<div class="product-image" >
    <span class="discount-tag">50% off</span>
    <Link to={{pathname: '/product/'+product.productID, state: { itemid: product.productID}}} >
    <img src={"data:image/png;base64," + product.image} width={206} height={206} class="product-thumb" alt="" />
    </Link>
    <button class="card-btn">add to whislist</button>
</div>
<div class="product-info">
    <h2 class="product-brand">{product.name}</h2>
    <p class="product-short-des">a short line about the cloth..</p>
    <span class="price">{product.price}bath</span><span class="actual-price">300 bath</span>
</div>
</div>
    );
}
export default CardProduct;