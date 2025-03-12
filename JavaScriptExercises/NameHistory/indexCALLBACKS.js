
// Optimised form of the code
// 1: Implemented Callbacks to prevent unnecessary re-renders by memorizing 'handleInputChange', 'updateName' and 'clearHistory'.
// 2: Destructed properties directly within the 'Hello' and 'nameHistory'

const { useState, useCallback } = React;

const App = () => {
  const [name, setName] = useState('React Learner');
  const [input, setInput] = useState('');
  const [history, setHistory] = useState([]);

  const handleInputChange = useCallback((e) => setInput(e.target.value), []);

  const updateName = useCallback(() => {
    setName(input);
    setHistory((prevHistory) => [...prevHistory, input]);
    setInput('');
  }, [input]);

  const clearHistory = useCallback(() => setHistory([]), []);

  return React.createElement('div', null,
    React.createElement(Hello, { name }),
    React.createElement('input', { type: 'text', value: input, onChange: handleInputChange }),
    React.createElement('button', { onClick: updateName }, 'Update Name'),
    React.createElement(NameHistory, { history, clearHistory })
  );
};

const Hello = ({ name }) => React.createElement('h1', null, `Hello, ${name}!`);

const NameHistory = ({ history, clearHistory }) =>
  React.createElement('div', null,
    React.createElement('h2', null, 'Name History'),
    React.createElement('ul', null, history.map((name, index) => React.createElement('li', { key: index }, name))),
    React.createElement('button', { onClick: clearHistory }, 'Clear History')
  );

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(React.createElement(App));