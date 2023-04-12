import React from 'react'
import ReactStars from "react-rating-stars-component";
import { Link, useLocation } from 'react-router-dom';
import prodcompare from "../images/prodcompare.svg";
import wish from "../images/wish.svg";
import product1_2 from "../images/product1_2.png";
import addcart from "../images/add-cart.svg";
import view from "../images/view.svg";
const ProductCard = (props) => {
  const { img } = props;
  const { name  } = props;
  const { price  } = props;
  const { id  } = props;
  const { grid } =props;
  let location = useLocation();
  return (
    <>
      <div
        className={`${
          location.pathname === "/product" ? `gr-${grid}` : "col-3"
        }`}
      >
        <Link to={{
          pathname:'/product/'+id}}
          className="product-card position-relative"
        >
          <div className="wishlist-icon position-absolute">
            <button className="border-0 bg-transparent">
              <img src={wish} alt="wishlist" />
            </button>
          </div>
          <div className="product-image">
            <img src={"data:image/png;base64," + img} className="img-fluid" alt="productimage" />
            <img src={product1_2} className="img-fluid" alt="productimage " />
          </div>
          <div className="product-details">
            <h6 className="brand"> New</h6>
            <h5 className="product-title">{name}</h5>
            <ReactStars
              count={5}
              size={24}
              value="4"
              edit={false}
              activeColor="#ffd700"
            />
            <p className={`description ${grid === 12 ? "d-block" : "d-none"} `}>
            เสื้อผ้าสำหรับเด็ก
            </p>
            <p className="price">{price} Bath</p>
          </div>
          <div className="action-bar position-absolute">
            <div className="d-flex flex-column">
              <button className="border-0 bg-transparent">
                <img src={prodcompare} alt="addcart" />
              </button>
              <button className="border-0 bg-transparent">
                <img src={view} alt="addcart" />
              </button>
              <button className="border-0 bg-transparent">
                <img src={addcart} alt="addcart" />
              </button>
            </div>
          </div>
        </Link>
      </div>
    </>
  );
};

export default ProductCard;
