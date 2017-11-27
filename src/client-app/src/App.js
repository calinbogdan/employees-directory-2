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
    this.formSubmitHandler = this.formSubmitHandler.bind(this);
  }

  // lifecycle methods

  componentWillMount() {
    this.getEmployees();
  }


  // custom functions

  getEmployees() {
    console.log('Fetching employees...');
    fetch('http://localhost:5000/api/employees')
    .then(response => response.json())
    .then(employeesArray => {
      this.setState({
        employees: employeesArray
      });
    })
  }

  // handlers

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
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({
        name: this.state.name,
        email: this.state.email,
        hiredOn: new Date()
      })
    })
    .then(response => response.json())
    .then(hiredEmployee => {
      let newArray = this.state.employees.slice();
      newArray.push(hiredEmployee);
      this.setState({
        employees: newArray
      });
    })
    .catch(error => {
      console.log(error);
    });
  }
  
  render() {
    return (
      <div className="App">
        <h1>Thundrware's Employees Directory</h1>
        <ul>
          {this.state.employees.map(employee => {
            return (<li key={employee.id}>
                      <h1>Name: {employee.name}</h1>
                      <h3>Email: {employee.email}</h3>
                    </li>);
          })}
        </ul>

        <form onSubmit={this.formSubmitHandler}>
          <input type="text" placeholder="Input name" onChange={this.nameInputChangeHandler} value={this.state.name}/><br/>
          <input type="text" placeholder="Input email" onChange={this.emailInputChangeHandler} value={this.state.email}/><br/>
          <input type="submit" value="Submit"/>
        </form>
        
      </div>
    );
  }
}

export default App;
