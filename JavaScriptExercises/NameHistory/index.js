const { useState } = React; // Imports 'useState' from React to allow functions to return a React element.

// Functional Component for the 'App'
const App = () => {
  const [name, setName] = useState('React Learner'); // Stores the current name
  const [input, setInput] = useState(''); // Stores current input
  const [history, setHistory] = useState([]); // Stores name history

  const handleInputChange = (e) => setInput(e.target.value); // Updates the input value

  const updateName = () => {
    setName(input); // Sets name to the current input
    setHistory([...history, input]); // Updates the name history
    setInput(''); // Clears the current input
  };

  const clearHistory = () => setHistory([]); // Resets history array

  return React.createElement('div', null,
    React.createElement(Hello, { name }), // Hello Function called with the current name to update html title
    React.createElement('input', { type: 'text', value: input, onChange: handleInputChange }), // Input box bound to the 'onChange' event handler
    React.createElement('button', { onClick: updateName }, 'Update Name'), // Button element bound to the 'onClick updateName' handler
    React.createElement(NameHistory, { history, clearHistory }) // Calling the name history component with relevent arrays parsed
  );
};

const Hello = ({ name }) => React.createElement('h1', null, `Hello, ${name}!`); // Displays dynamic greet message

const NameHistory = ({ history, clearHistory }) =>
  React.createElement( 'div', null,
    React.createElement('h2', null, 'Name History'), // 'Name History' Heading
    React.createElement('ul', null, history.map((name, index) => React.createElement('li', { key: index }, name))), // Unordered list of previous names formatted by a map function
    React.createElement('button', { onClick: clearHistory }, 'Clear History') // Clear history button bound to the 'clearHistory' function.
  );

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(React.createElement(App));