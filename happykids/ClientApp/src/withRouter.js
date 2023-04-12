import {useParams,useNavigate} from 'react-router-dom';

export function withRouter( Child ) {
    return ( props ) => {
      const pid = useParams();
      const navigate = useNavigate();
      return <Child { ...props } id ={ pid } />;
    }
  }
  