import React from 'react';
import PropTypes from 'prop-types';
import Table, {
    TableBody,
    TableHead,
    TableCell,
    TableRow
  } from 'material-ui/Table';
import Employee from './Employee';
import Paper from 'material-ui/Paper';
import Grid from 'material-ui/Grid';

export default class EmployeesList extends React.Component {

    static propTypes = {
        employees: PropTypes.array.isRequired
    }

    render() {
        return (
            <Grid container justify="center" md={12}>
                <Paper>
                    <Table>
                        <TableHead>
                            <TableRow>
                                <TableCell>No.</TableCell>
                                <TableCell>Name</TableCell>
                                <TableCell>Email</TableCell>
                                <TableCell>Hired on</TableCell>
                                <TableCell></TableCell>
                                <TableCell></TableCell>
                            </TableRow>
                        </TableHead>
                        <TableBody>
                            {this.props.employees.map(employee => {
                                return <Employee employee={employee}/>
                            })}
                        </TableBody>
                    </Table>
                </Paper>
            </Grid>
        );
    }
}