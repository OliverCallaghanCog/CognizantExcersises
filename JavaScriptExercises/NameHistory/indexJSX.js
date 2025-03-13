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

  // Functionaly Component to Display Name History
  const NameHistory = ({ history, clearHistory }) => (
    <div>
      <h2>Name History</h2>
      <ul>
        {history.map((name, index) => (<li key={index}>{name}</li>))}
      </ul>
      <button onClick={clearHistory}>Clear History</button>
    </div>
  );
  
  const root = ReactDOM.createRoot(document.getElementById('root'));
  root.render(<App />);