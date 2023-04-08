import React, { Component } from 'react';


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

  render() {
    
    return (
      
      <div>
        <h1>Hello, world!</h1>
        <p>Welcome to your new single-page application, built with:</p>
        <ul>
          <li><a href='https://get.asp.net/'>ASP.NET Core</a> and <a href='https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx'>C#</a> for cross-platform server-side code</li>
          <li><a href='https://facebook.github.io/react/'>React</a> for client-side code</li>
          <li><a href='http://getbootstrap.com/'>Bootstrap</a> for layout and styling</li>
        </ul>
        <p>To help you get started, we have also set up:</p>
        <ul>
          <li><strong>Client-side navigation</strong>. For example, click <em>Counter</em> then <em>Back</em> to return here.</li>
          <li><strong>Development server integration</strong>. In development mode, the development server from <code>create-react-app</code> runs in the background automatically, so your client-side resources are dynamically built on demand and the page refreshes when you modify any file.</li>
          <li><strong>Efficient production builds</strong>. In production mode, development-time features are disabled, and your <code>dotnet publish</code> configuration produces minified, efficiently bundled JavaScript files.</li>
        </ul>
        <p>The <code>ClientApp</code> subdirectory is a standard React application based on the <code>create-react-app</code> template. If you open a command prompt in that directory, you can run <code>npm</code> commands such as <code>npm test</code> or <code>npm install</code>.</p>
        <RenderingArrayOfObjects />
        <RenderingArrayOfObjects2 />
      </div>
    );
  }
}
