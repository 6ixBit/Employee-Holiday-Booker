﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee_Desktop.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Holidays", Namespace="http://tempurideya.org/")]
    [System.SerializableAttribute()]
    public partial class Holidays : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int holiday_idField;
        
        private int Employee_IDField;
        
        private int Holiday_ID1Field;
        
        private System.DateTime Holiday_startField;
        
        private System.DateTime Holiday_endField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Holiday_statusField;
        
        private bool Days_exceededField;
        
        private bool Head_depHead_absentField;
        
        private bool department_AbsentField;
        
        private bool SeniorStaff_absentField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int holiday_id {
            get {
                return this.holiday_idField;
            }
            set {
                if ((this.holiday_idField.Equals(value) != true)) {
                    this.holiday_idField = value;
                    this.RaisePropertyChanged("holiday_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int Employee_ID {
            get {
                return this.Employee_IDField;
            }
            set {
                if ((this.Employee_IDField.Equals(value) != true)) {
                    this.Employee_IDField = value;
                    this.RaisePropertyChanged("Employee_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Holiday_ID", IsRequired=true, Order=2)]
        public int Holiday_ID1 {
            get {
                return this.Holiday_ID1Field;
            }
            set {
                if ((this.Holiday_ID1Field.Equals(value) != true)) {
                    this.Holiday_ID1Field = value;
                    this.RaisePropertyChanged("Holiday_ID1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.DateTime Holiday_start {
            get {
                return this.Holiday_startField;
            }
            set {
                if ((this.Holiday_startField.Equals(value) != true)) {
                    this.Holiday_startField = value;
                    this.RaisePropertyChanged("Holiday_start");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.DateTime Holiday_end {
            get {
                return this.Holiday_endField;
            }
            set {
                if ((this.Holiday_endField.Equals(value) != true)) {
                    this.Holiday_endField = value;
                    this.RaisePropertyChanged("Holiday_end");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Holiday_status {
            get {
                return this.Holiday_statusField;
            }
            set {
                if ((object.ReferenceEquals(this.Holiday_statusField, value) != true)) {
                    this.Holiday_statusField = value;
                    this.RaisePropertyChanged("Holiday_status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public bool Days_exceeded {
            get {
                return this.Days_exceededField;
            }
            set {
                if ((this.Days_exceededField.Equals(value) != true)) {
                    this.Days_exceededField = value;
                    this.RaisePropertyChanged("Days_exceeded");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public bool Head_depHead_absent {
            get {
                return this.Head_depHead_absentField;
            }
            set {
                if ((this.Head_depHead_absentField.Equals(value) != true)) {
                    this.Head_depHead_absentField = value;
                    this.RaisePropertyChanged("Head_depHead_absent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public bool department_Absent {
            get {
                return this.department_AbsentField;
            }
            set {
                if ((this.department_AbsentField.Equals(value) != true)) {
                    this.department_AbsentField = value;
                    this.RaisePropertyChanged("department_Absent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public bool SeniorStaff_absent {
            get {
                return this.SeniorStaff_absentField;
            }
            set {
                if ((this.SeniorStaff_absentField.Equals(value) != true)) {
                    this.SeniorStaff_absentField = value;
                    this.RaisePropertyChanged("SeniorStaff_absent");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempurideya.org/", ConfigurationName="ServiceReference1.TheWebServiceSoap")]
    public interface TheWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempurideya.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempurideya.org/login_employee", ReplyAction="*")]
        Employee_Desktop.ServiceReference1.login_employeeResponse login_employee(Employee_Desktop.ServiceReference1.login_employeeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempurideya.org/login_employee", ReplyAction="*")]
        System.Threading.Tasks.Task<Employee_Desktop.ServiceReference1.login_employeeResponse> login_employeeAsync(Employee_Desktop.ServiceReference1.login_employeeRequest request);
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempurideya.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempurideya.org/submit_holiday_request", ReplyAction="*")]
        Employee_Desktop.ServiceReference1.submit_holiday_requestResponse submit_holiday_request(Employee_Desktop.ServiceReference1.submit_holiday_requestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempurideya.org/submit_holiday_request", ReplyAction="*")]
        System.Threading.Tasks.Task<Employee_Desktop.ServiceReference1.submit_holiday_requestResponse> submit_holiday_requestAsync(Employee_Desktop.ServiceReference1.submit_holiday_requestRequest request);
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempurideya.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempurideya.org/get_outstanding_holiday_requests_for_employee", ReplyAction="*")]
        Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeResponse get_outstanding_holiday_requests_for_employee(Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempurideya.org/get_outstanding_holiday_requests_for_employee", ReplyAction="*")]
        System.Threading.Tasks.Task<Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeResponse> get_outstanding_holiday_requests_for_employeeAsync(Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeRequest request);
        
        // CODEGEN: Generating message contract since element name emp_email from namespace http://tempurideya.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempurideya.org/submit_holiday_with_constraint_checking", ReplyAction="*")]
        Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingResponse submit_holiday_with_constraint_checking(Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempurideya.org/submit_holiday_with_constraint_checking", ReplyAction="*")]
        System.Threading.Tasks.Task<Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingResponse> submit_holiday_with_constraint_checkingAsync(Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class login_employeeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="login_employee", Namespace="http://tempurideya.org/", Order=0)]
        public Employee_Desktop.ServiceReference1.login_employeeRequestBody Body;
        
        public login_employeeRequest() {
        }
        
        public login_employeeRequest(Employee_Desktop.ServiceReference1.login_employeeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempurideya.org/")]
    public partial class login_employeeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public login_employeeRequestBody() {
        }
        
        public login_employeeRequestBody(string email, string password) {
            this.email = email;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class login_employeeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="login_employeeResponse", Namespace="http://tempurideya.org/", Order=0)]
        public Employee_Desktop.ServiceReference1.login_employeeResponseBody Body;
        
        public login_employeeResponse() {
        }
        
        public login_employeeResponse(Employee_Desktop.ServiceReference1.login_employeeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempurideya.org/")]
    public partial class login_employeeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool login_employeeResult;
        
        public login_employeeResponseBody() {
        }
        
        public login_employeeResponseBody(bool login_employeeResult) {
            this.login_employeeResult = login_employeeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class submit_holiday_requestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="submit_holiday_request", Namespace="http://tempurideya.org/", Order=0)]
        public Employee_Desktop.ServiceReference1.submit_holiday_requestRequestBody Body;
        
        public submit_holiday_requestRequest() {
        }
        
        public submit_holiday_requestRequest(Employee_Desktop.ServiceReference1.submit_holiday_requestRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempurideya.org/")]
    public partial class submit_holiday_requestRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public System.DateTime holiday_start;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.DateTime holiday_end;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public bool days_exceeded;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public bool head_depHead_absent;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public bool seniorStaff_absent;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public bool Department_absent;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string holiday_status;
        
        public submit_holiday_requestRequestBody() {
        }
        
        public submit_holiday_requestRequestBody(string email, System.DateTime holiday_start, System.DateTime holiday_end, bool days_exceeded, bool head_depHead_absent, bool seniorStaff_absent, bool Department_absent, string holiday_status) {
            this.email = email;
            this.holiday_start = holiday_start;
            this.holiday_end = holiday_end;
            this.days_exceeded = days_exceeded;
            this.head_depHead_absent = head_depHead_absent;
            this.seniorStaff_absent = seniorStaff_absent;
            this.Department_absent = Department_absent;
            this.holiday_status = holiday_status;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class submit_holiday_requestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="submit_holiday_requestResponse", Namespace="http://tempurideya.org/", Order=0)]
        public Employee_Desktop.ServiceReference1.submit_holiday_requestResponseBody Body;
        
        public submit_holiday_requestResponse() {
        }
        
        public submit_holiday_requestResponse(Employee_Desktop.ServiceReference1.submit_holiday_requestResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class submit_holiday_requestResponseBody {
        
        public submit_holiday_requestResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class get_outstanding_holiday_requests_for_employeeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="get_outstanding_holiday_requests_for_employee", Namespace="http://tempurideya.org/", Order=0)]
        public Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeRequestBody Body;
        
        public get_outstanding_holiday_requests_for_employeeRequest() {
        }
        
        public get_outstanding_holiday_requests_for_employeeRequest(Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempurideya.org/")]
    public partial class get_outstanding_holiday_requests_for_employeeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        public get_outstanding_holiday_requests_for_employeeRequestBody() {
        }
        
        public get_outstanding_holiday_requests_for_employeeRequestBody(string email) {
            this.email = email;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class get_outstanding_holiday_requests_for_employeeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="get_outstanding_holiday_requests_for_employeeResponse", Namespace="http://tempurideya.org/", Order=0)]
        public Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeResponseBody Body;
        
        public get_outstanding_holiday_requests_for_employeeResponse() {
        }
        
        public get_outstanding_holiday_requests_for_employeeResponse(Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempurideya.org/")]
    public partial class get_outstanding_holiday_requests_for_employeeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Employee_Desktop.ServiceReference1.Holidays[] get_outstanding_holiday_requests_for_employeeResult;
        
        public get_outstanding_holiday_requests_for_employeeResponseBody() {
        }
        
        public get_outstanding_holiday_requests_for_employeeResponseBody(Employee_Desktop.ServiceReference1.Holidays[] get_outstanding_holiday_requests_for_employeeResult) {
            this.get_outstanding_holiday_requests_for_employeeResult = get_outstanding_holiday_requests_for_employeeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class submit_holiday_with_constraint_checkingRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="submit_holiday_with_constraint_checking", Namespace="http://tempurideya.org/", Order=0)]
        public Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingRequestBody Body;
        
        public submit_holiday_with_constraint_checkingRequest() {
        }
        
        public submit_holiday_with_constraint_checkingRequest(Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempurideya.org/")]
    public partial class submit_holiday_with_constraint_checkingRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string emp_email;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public System.DateTime holiday_start;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.DateTime holiday_end;
        
        public submit_holiday_with_constraint_checkingRequestBody() {
        }
        
        public submit_holiday_with_constraint_checkingRequestBody(string emp_email, System.DateTime holiday_start, System.DateTime holiday_end) {
            this.emp_email = emp_email;
            this.holiday_start = holiday_start;
            this.holiday_end = holiday_end;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class submit_holiday_with_constraint_checkingResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="submit_holiday_with_constraint_checkingResponse", Namespace="http://tempurideya.org/", Order=0)]
        public Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingResponseBody Body;
        
        public submit_holiday_with_constraint_checkingResponse() {
        }
        
        public submit_holiday_with_constraint_checkingResponse(Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class submit_holiday_with_constraint_checkingResponseBody {
        
        public submit_holiday_with_constraint_checkingResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TheWebServiceSoapChannel : Employee_Desktop.ServiceReference1.TheWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TheWebServiceSoapClient : System.ServiceModel.ClientBase<Employee_Desktop.ServiceReference1.TheWebServiceSoap>, Employee_Desktop.ServiceReference1.TheWebServiceSoap {
        
        public TheWebServiceSoapClient() {
        }
        
        public TheWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TheWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TheWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TheWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Employee_Desktop.ServiceReference1.login_employeeResponse Employee_Desktop.ServiceReference1.TheWebServiceSoap.login_employee(Employee_Desktop.ServiceReference1.login_employeeRequest request) {
            return base.Channel.login_employee(request);
        }
        
        public bool login_employee(string email, string password) {
            Employee_Desktop.ServiceReference1.login_employeeRequest inValue = new Employee_Desktop.ServiceReference1.login_employeeRequest();
            inValue.Body = new Employee_Desktop.ServiceReference1.login_employeeRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            Employee_Desktop.ServiceReference1.login_employeeResponse retVal = ((Employee_Desktop.ServiceReference1.TheWebServiceSoap)(this)).login_employee(inValue);
            return retVal.Body.login_employeeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Employee_Desktop.ServiceReference1.login_employeeResponse> Employee_Desktop.ServiceReference1.TheWebServiceSoap.login_employeeAsync(Employee_Desktop.ServiceReference1.login_employeeRequest request) {
            return base.Channel.login_employeeAsync(request);
        }
        
        public System.Threading.Tasks.Task<Employee_Desktop.ServiceReference1.login_employeeResponse> login_employeeAsync(string email, string password) {
            Employee_Desktop.ServiceReference1.login_employeeRequest inValue = new Employee_Desktop.ServiceReference1.login_employeeRequest();
            inValue.Body = new Employee_Desktop.ServiceReference1.login_employeeRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            return ((Employee_Desktop.ServiceReference1.TheWebServiceSoap)(this)).login_employeeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Employee_Desktop.ServiceReference1.submit_holiday_requestResponse Employee_Desktop.ServiceReference1.TheWebServiceSoap.submit_holiday_request(Employee_Desktop.ServiceReference1.submit_holiday_requestRequest request) {
            return base.Channel.submit_holiday_request(request);
        }
        
        public void submit_holiday_request(string email, System.DateTime holiday_start, System.DateTime holiday_end, bool days_exceeded, bool head_depHead_absent, bool seniorStaff_absent, bool Department_absent, string holiday_status) {
            Employee_Desktop.ServiceReference1.submit_holiday_requestRequest inValue = new Employee_Desktop.ServiceReference1.submit_holiday_requestRequest();
            inValue.Body = new Employee_Desktop.ServiceReference1.submit_holiday_requestRequestBody();
            inValue.Body.email = email;
            inValue.Body.holiday_start = holiday_start;
            inValue.Body.holiday_end = holiday_end;
            inValue.Body.days_exceeded = days_exceeded;
            inValue.Body.head_depHead_absent = head_depHead_absent;
            inValue.Body.seniorStaff_absent = seniorStaff_absent;
            inValue.Body.Department_absent = Department_absent;
            inValue.Body.holiday_status = holiday_status;
            Employee_Desktop.ServiceReference1.submit_holiday_requestResponse retVal = ((Employee_Desktop.ServiceReference1.TheWebServiceSoap)(this)).submit_holiday_request(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Employee_Desktop.ServiceReference1.submit_holiday_requestResponse> Employee_Desktop.ServiceReference1.TheWebServiceSoap.submit_holiday_requestAsync(Employee_Desktop.ServiceReference1.submit_holiday_requestRequest request) {
            return base.Channel.submit_holiday_requestAsync(request);
        }
        
        public System.Threading.Tasks.Task<Employee_Desktop.ServiceReference1.submit_holiday_requestResponse> submit_holiday_requestAsync(string email, System.DateTime holiday_start, System.DateTime holiday_end, bool days_exceeded, bool head_depHead_absent, bool seniorStaff_absent, bool Department_absent, string holiday_status) {
            Employee_Desktop.ServiceReference1.submit_holiday_requestRequest inValue = new Employee_Desktop.ServiceReference1.submit_holiday_requestRequest();
            inValue.Body = new Employee_Desktop.ServiceReference1.submit_holiday_requestRequestBody();
            inValue.Body.email = email;
            inValue.Body.holiday_start = holiday_start;
            inValue.Body.holiday_end = holiday_end;
            inValue.Body.days_exceeded = days_exceeded;
            inValue.Body.head_depHead_absent = head_depHead_absent;
            inValue.Body.seniorStaff_absent = seniorStaff_absent;
            inValue.Body.Department_absent = Department_absent;
            inValue.Body.holiday_status = holiday_status;
            return ((Employee_Desktop.ServiceReference1.TheWebServiceSoap)(this)).submit_holiday_requestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeResponse Employee_Desktop.ServiceReference1.TheWebServiceSoap.get_outstanding_holiday_requests_for_employee(Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeRequest request) {
            return base.Channel.get_outstanding_holiday_requests_for_employee(request);
        }
        
        public Employee_Desktop.ServiceReference1.Holidays[] get_outstanding_holiday_requests_for_employee(string email) {
            Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeRequest inValue = new Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeRequest();
            inValue.Body = new Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeRequestBody();
            inValue.Body.email = email;
            Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeResponse retVal = ((Employee_Desktop.ServiceReference1.TheWebServiceSoap)(this)).get_outstanding_holiday_requests_for_employee(inValue);
            return retVal.Body.get_outstanding_holiday_requests_for_employeeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeResponse> Employee_Desktop.ServiceReference1.TheWebServiceSoap.get_outstanding_holiday_requests_for_employeeAsync(Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeRequest request) {
            return base.Channel.get_outstanding_holiday_requests_for_employeeAsync(request);
        }
        
        public System.Threading.Tasks.Task<Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeResponse> get_outstanding_holiday_requests_for_employeeAsync(string email) {
            Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeRequest inValue = new Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeRequest();
            inValue.Body = new Employee_Desktop.ServiceReference1.get_outstanding_holiday_requests_for_employeeRequestBody();
            inValue.Body.email = email;
            return ((Employee_Desktop.ServiceReference1.TheWebServiceSoap)(this)).get_outstanding_holiday_requests_for_employeeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingResponse Employee_Desktop.ServiceReference1.TheWebServiceSoap.submit_holiday_with_constraint_checking(Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingRequest request) {
            return base.Channel.submit_holiday_with_constraint_checking(request);
        }
        
        public void submit_holiday_with_constraint_checking(string emp_email, System.DateTime holiday_start, System.DateTime holiday_end) {
            Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingRequest inValue = new Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingRequest();
            inValue.Body = new Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingRequestBody();
            inValue.Body.emp_email = emp_email;
            inValue.Body.holiday_start = holiday_start;
            inValue.Body.holiday_end = holiday_end;
            Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingResponse retVal = ((Employee_Desktop.ServiceReference1.TheWebServiceSoap)(this)).submit_holiday_with_constraint_checking(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingResponse> Employee_Desktop.ServiceReference1.TheWebServiceSoap.submit_holiday_with_constraint_checkingAsync(Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingRequest request) {
            return base.Channel.submit_holiday_with_constraint_checkingAsync(request);
        }
        
        public System.Threading.Tasks.Task<Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingResponse> submit_holiday_with_constraint_checkingAsync(string emp_email, System.DateTime holiday_start, System.DateTime holiday_end) {
            Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingRequest inValue = new Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingRequest();
            inValue.Body = new Employee_Desktop.ServiceReference1.submit_holiday_with_constraint_checkingRequestBody();
            inValue.Body.emp_email = emp_email;
            inValue.Body.holiday_start = holiday_start;
            inValue.Body.holiday_end = holiday_end;
            return ((Employee_Desktop.ServiceReference1.TheWebServiceSoap)(this)).submit_holiday_with_constraint_checkingAsync(inValue);
        }
    }
}