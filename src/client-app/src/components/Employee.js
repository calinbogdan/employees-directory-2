import React from 'react';
import PropTypes from 'prop-types';
import {
    TableRow,
    TableCell
} from 'material-ui/Table';
import Button from 'material-ui/Button';

export default class Employee extends React.Component {

    static propTypes = {
        employee: PropTypes.shape({
            id: PropTypes.number.isRequired,
            name: PropTypes.string.isRequired,
            email: PropTypes.string.isRequired,
            hiredOn: PropTypes.string.isRequired
        }),
        deleteHandler: PropTypes.func.isRequired
    }

    render() {
        return (
            <TableRow hover>
                <TableCell>{this.props.employee.id}</TableCell>
                <TableCell>{this.props.employee.name}</TableCell>
                <TableCell>{this.props.employee.email}</TableCell>
                <TableCell>{this.props.employee.hiredOn}</TableCell>
                <TableCell>
                    <Button>
                        Edit
                    </Button>
                </TableCell>
                <TableCell>
                    <Button>
                        Delete
                    </Button>
                </TableCell>
            </TableRow>
        )
    }
}


