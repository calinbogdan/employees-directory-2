import React, { Component } from 'react';

class App extends Component {
  
  constructor() {
    super();
    this.state = {
      employees: [],
      name: '',
      email: ''
    }
    this.nameInputChangeHandler = this.nameInputChangeHandler.bind(this);
    this.emailInputChangeHandler = this.emailInputChangeHandler.bind(this);
  }

  nameInputChangeHandler(event) {
    this.setState({
      name: event.target.value
    });
  }

  emailInputChangeHandler(event) {
    this.setState({
      email: event.target.value
    });
  }

  formSubmitHandler(event) {
    event.preventDefault();
    fetch('http://localhost:5000/api/employees', {
      method: 'POST',
      headers: {
        'Accept': 'application/json',
        'Content': 'application/json'
      },
      body: JSON.stringify({
        name: this.state.name,
        email: this.state.email
      })
    })
    .then(response => response.json())
    .then(responseJson => {
      console.log(responseJson);
    })
    .catch(error => {
      console.log(error);
    });
  }
  
  render() {
    return (
      <div className="App">
        <h1>Thundrware's Employees Directory</h1>
        <form>
          <input type="text" placeholder="Input name" onChange={this.nameInputChangeHandler} value={this.state.name}/><br/>
          <input type="text" placeholder="Input email" onChange={this.emailInputChangeHandler} value={this.state.email}/><br/>
          <input type="submit" value="Submit"/>
        </form>
        
      </div>
    );
  }
}

export default App;
