### Interactive React Components and Virtual DOM Exercise

#### Objective:
Demonstrate your understanding of React components, JSX syntax, interactive state management, and how the Virtual DOM is instantiated and updated.

#### Starting HTML and JavaScript:

**index.html:**
```html
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <title>React Virtual DOM Exercise</title>
  <script crossorigin src="https://unpkg.com/react@18/umd/react.development.js"></script>
  <script crossorigin src="https://unpkg.com/react-dom@18/umd/react-dom.development.js"></script>
  <script src="index.js" defer></script>
</head>
<body>
  <div id="root"></div>
</body>
</html>
```

**index.js:**
```jsx
class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = { name: 'React Learner', input: '' };
  }

  handleInputChange = (e) => {
    this.setState({ input: e.target.value });
  };

  updateName = () => {
    this.setState({ name: this.state.input });
  };

  render() {
    return (
      <div>
        <Hello name={this.state.name} />
        <input type="text" value={this.state.input} onChange={this.handleInputChange} />
        <button onClick={this.updateName}>Update Name</button>
      </div>
    );
  }
}

const Hello = ({ name }) => <h1>Hello, {name}!</h1>;

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(<App />);
```

#### Additional Challenge:
- Extend your application by adding a new feature: a dynamic list component (`NameHistory`) that tracks and displays a history of all the previous names entered by the user.
- Provide the ability to clear the history list.

#### Instructions:

1. Recreate the provided starting HTML and JavaScript.
2. Complete the interactive input functionality.
3. Implement the additional challenge (`NameHistory` component).

#### Deliverables:
- Source code of your completed interactive React application.
- A concise explanation (2-3 paragraphs) covering:
  - React’s Virtual DOM creation and update mechanisms.
  - How your additions demonstrate these React features.

#### Criteria for Success:
- Correctly implemented React application with dynamic state updates.
- Successfully integrated `NameHistory` component and clear functionality.
- Clear demonstration and explanation of React’s state management, Virtual DOM lifecycle, and JSX usage.

##### Note:

In the provided exercise, there is nothing you need to install. The provided HTML file already includes React and ReactDOM via CDN links. You can directly run the code by opening the HTML file in a browser.

However, ensure your files (index.html and index.js) are properly created and saved in the same folder to guarantee they work seamlessly.
