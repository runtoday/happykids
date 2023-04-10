import React, { Component } from 'react';
import HomeBanner from './HomeBanner';
import SingleProduct from "./Products/SingleProduct";


function RenderingArrayOfObjects2() {
  const data = 
  {
    "category": [
      {
        "categoryID": 1,
        "categoryName": "T shirts"
      },
      {
        "categoryID": 2,
        "categoryName": "Bodysuits"
      },
      {
        "categoryID": 3,
        "categoryName": "baby pants"
      }
    ],
    "color": [
      {
        "colorID": 1,
        "colorName": "Blue"
      },
      {
        "colorID": 2,
        "colorName": "Cream"
      },
      {
        "colorID": 3,
        "colorName": "Green"
      },
      {
        "colorID": 4,
        "colorName": "Light Pink"
      },
      {
        "colorID": 5,
        "colorName": "Peach"
      },
      {
        "colorID": 6,
        "colorName": "Terracota"
      },
      {
        "colorID": 7,
        "colorName": "White"
      }
    ],
    "size": [
      {
        "sizeID": 1,
        "sizeDesc": "0-3 months"
      },
      {
        "sizeID": 2,
        "sizeDesc": "3-6 months"
      },
      {
        "sizeID": 3,
        "sizeDesc": "6-12 months"
      },
      {
        "sizeID": 4,
        "sizeDesc": "12-18 months"
      },
      {
        "sizeID": 5,
        "sizeDesc": "18-24 months"
      },
      {
        "sizeID": 6,
        "sizeDesc": "2 years"
      },
      {
        "sizeID": 7,
        "sizeDesc": "3 years"
      }
    ]
  }
  const listItems = data.category.map(
      (element) => {
          return (
              <ul type="disc">
                  <li style={{ 
                      fontWeight: 'bold', 
                      color: 'red' }}
                  >
                      {element.categoryID}
                  </li>
                  <li>{element.categoryName}</li>
              </ul>
          )
      }
  )
  return (
      <div>
          {listItems}
      </div>
  )
}
function RenderingArrayOfObjects() {
  const data = [
      {
          "State": "Uttar Pradesh",
          "Capital": "Lucknow"
      },
      {
          "State": "Gujarat",
          "Capital": "Gandhinagar"
      },
      {
          "State": "Karnataka",
          "Capital": "Bengaluru"
      },
      {
          "State": "Punjab",
          "Capital": "Chandigarh"
      },
      {
          "State": "Maharashtra",
          "Capital": "Mumbai"
      }
  ]
  const listItems = data.map(
      (element) => {
          return (
              <ul type="disc">
                  <li style={{ 
                      fontWeight: 'bold', 
                      color: 'red' }}
                  >
                      {element.State}
                  </li>
                  <li>{element.Capital}</li>
              </ul>
          )
      }
  )
  return (
      <div>
          {listItems}
      </div>
  )
}

export class Home extends Component {
  static displayName = Home.name;
  constructor(props) {
    super(props);
    /*this.state = {
      products: this.props.products,
      productsBAK: this.props.products,
      departments: this.props.departments,
      modalShow: false,
      login: true
    };*/
    this.state = { products: [], loading: true };
    //this.addToBag = this.addToBag.bind(this);
  }
  componentDidMount() {
      this.getAllProducts();
  }

  async getAllProducts() {
    //const response = await fetch('weatherforecast');
    const response = await fetch('ProductService');
    const data = await response.json();
    //var img = 'data:image/png;base64,'+ this.arrayBufferToBase64(data.image);
    this.setState({ products: data, loading: false });
  }

  static   renderproducts(products){
        return (
          <div class="product-container">
          {products.map(product =>
          <div class="product-card">
              <div class="product-image">
                  <span class="discount-tag">50% off</span>
                  <img src={"data:image/png;base64," + product.image} width={206} height={206} class="product-thumb" alt=""/>
                  <button class="card-btn">add to whislist</button>
              </div>
              <div class="product-info">
                  <h2 class="product-brand">{product.name}</h2>
                  <p class="product-short-des">a short line about the cloth..</p>
                  <span class="price">{product.price}bath</span><span class="actual-price">300 bath</span>
              </div>
          </div>
          )}
          +7 more cards
          </div>
        );
  }

  
    
  // ? <p><em>Loading...</em></p>
  // : Home.renderproducts(this.state.products);
  // <HomeBanner/>
  render() {
    let product = this.state.loading
    ? <p><em>Loading...</em></p>
    : Home.renderproducts(this.state.products);
    return (    
    <div>
    <nav class="navbar">
    <div class="nav">
    <img src="../assets/images/dark-logo.png" class="brand-logo" alt="" />
    <div class="nav-items">
        <div class="search">
        <input type="text" class="search-box" placeholder="search brand, product" />
            <button class="search-btn">search</button>
        </div>
        <a href="#"><img src="../assets/images/user.png" alt="" /></a>
        <a href="#"><img src="../assets/images/cart.png" alt=""/></a>
    </div>
</div>
</nav>
      <HomeBanner/>
      <section class="product">
        <h2 class="product-category">All Product</h2>
      </section>
       {product}
      </div>
    );
  }
}
